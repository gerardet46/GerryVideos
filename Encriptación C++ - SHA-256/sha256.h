// Creado por: Gerard (Gerry Studios)
// Actualizado: 6 de julio de 2020
// NOTA: utiliza uint32_t para todos los elementos para usar siempre 32 bits (módulo 2^32)

#pragma once

#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <math.h>

#define HEX "0123456789abcdef"
#define H_INICIAL { 0x6a09e667, 0xbb67ae85, 0x3c6ef372, 0xa54ff53a, 0x510e527f, 0x9b05688c, 0x1f83d9ab, 0x5be0cd19 }

#define SR(n,d) ((n >> d) | (n << (32 - d)))
#define Ch(x,y,z) ((x & y) ^ (~x & z))
#define Maj(a,b,c) ((a & b) ^ (a & c) ^ (b & c))
#define s0(x) (SR(x, 2) ^ SR(x, 13) ^ SR(x, 22))
#define s1(x) (SR(x, 6) ^ SR(x, 11) ^ SR(x, 25))
#define o0(x) (SR(x, 7) ^ SR(x, 18) ^ (x >> 3))
#define o1(x) (SR(x, 17) ^ SR(x, 19) ^ (x >> 10))

using namespace std;


// constantes K
uint32_t K[64] = {
	0x428a2f98,0x71374491,0xb5c0fbcf,0xe9b5dba5,0x3956c25b,0x59f111f1,
	0x923f82a4,0xab1c5ed5,0xd807aa98,0x12835b01,0x243185be,0x550c7dc3,
	0x72be5d74,0x80deb1fe,0x9bdc06a7,0xc19bf174,0xe49b69c1,0xefbe4786,
	0x0fc19dc6,0x240ca1cc,0x2de92c6f,0x4a7484aa,0x5cb0a9dc,0x76f988da,
	0x983e5152,0xa831c66d,0xb00327c8,0xbf597fc7,0xc6e00bf3,0xd5a79147,
	0x06ca6351,0x14292967,0x27b70a85,0x2e1b2138,0x4d2c6dfc,0x53380d13,
	0x650a7354,0x766a0abb,0x81c2c92e,0x92722c85,0xa2bfe8a1,0xa81a664b,
	0xc24b8b70,0xc76c51a3,0xd192e819,0xd6990624,0xf40e3585,0x106aa070,
	0x19a4c116,0x1e376c08,0x2748774c,0x34b0bcb5,0x391c0cb3,0x4ed8aa4a,
	0x5b9cca4f,0x682e6ff3,0x748f82ee,0x78a5636f,0x84c87814,0x8cc70208,
	0x90befffa,0xa4506ceb,0xbef9a3f7,0xc67178f2
};
// para los hashes
uint32_t H[8] = H_INICIAL;

/*********************/
// representación binaria de un número
string int2bin(int n, int bits = 8) {
	string r = string(bits, '0');
	while (n) {
		r.at(--bits) = ((n & 1) + 48);
		n >>= 1;
	}
	return r;
}

// mensaje a binario
string msg2bin(string t) {
	string r = "";
	for (auto c : t) r += int2bin(c);
	return r;
}
// binario a entero
int bin2int(string b) {
	int r = 0;
	for (int i = 0; i < b.length(); i++) r += b.at(b.length() - 1 - i) == '1' ? pow(2, i) : 0;
	return r;
}
// representación hexadecimal
string toHEX(uint32_t n, int digits) {
	string res = string(digits, '0');
	int ind = -1, mod = 0;
	while (n > 15) {
		mod = n % 16;
		res.at(++ind) = HEX[mod];
		n = (n - mod) / 16;
	}
	res.at(++ind) = HEX[n];
	reverse(res.begin(), res.end());
	return res;
}
/**************************************************/
struct SHA256 {
	static string cifrar(string t);
};

// función hash de SHA256
string SHA256::cifrar(string t) {
	uint32_t ini[] = H_INICIAL;
	for (int i = 0; i < 8; i++) H[i] = ini[i];
	string msg = msg2bin(t) + "1";
	int longitud_original = msg.length() - 1;
	while (msg.length() % 512 != 448) msg += '0';

	msg += int2bin(longitud_original, 64);
	
	// dividimos en bloques de 512 bits
	vector<vector<int>> M = vector<vector<int>>();
	for (int i = 0; i < msg.length(); i += 512) {
		vector<int> trozo = vector<int>(16);
		string sub_msg = msg.substr(i, 512);

		for (int j = 0; j < 512; j += 32) {
			string n = sub_msg.substr(j, 32);
			trozo.at(j / 32) = bin2int(n);
		}
		M.push_back(trozo);
	}

	for (auto Mi : M) {
		uint32_t a = H[0], b = H[1], c = H[2], d = H[3], e = H[4], f = H[5], g = H[6], h = H[7];
		vector<uint32_t> W = vector<uint32_t>(64);
		for (int i = 0; i < 64; i++) {
			if (i < 16) W[i] = Mi[i];
			else W[i] = o1(W.at(i - 2)) + W.at(i - 7) + o0(W.at(i - 15)) + W.at(i - 16);


			uint32_t T1 = h + s1(e) + Ch(e, f, g) + K[i] + W[i];
			uint32_t T2 = s0(a) + Maj(a, b, c);

			h = g;
			g = f;
			f = e;
			e = d + T1;
			d = c;
			c = b; 
			b = a;
			a = T1 + T2;
			
			// descomentar esto para ver cada iteración
			/*cout << "t=" << i << " => ";
			cout << toHEX(a,8) << "  ";
			cout << toHEX(b,8) << "  ";
			cout << toHEX(c,8) << "  ";
			cout << toHEX(d,8) << "  ";
			cout << toHEX(e,8) << "  ";
			cout << toHEX(f,8) << "  ";
			cout << toHEX(g,8) << "  ";
			cout << toHEX(h,8) << endl;*/
		}
		H[0] = a + H[0];
		H[1] = b + H[1];
		H[2] = c + H[2];
		H[3] = d + H[3];
		H[4] = e + H[4];
		H[5] = f + H[5];
		H[6] = g + H[6];
		H[7] = h + H[7];
	}
	
	// juntamos los hashes para mostrar el resultado
	string resultado = "";
	for (auto h : H) resultado += toHEX(h, 8);
	return resultado;
}
