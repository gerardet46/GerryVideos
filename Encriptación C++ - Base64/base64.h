#pragma once

#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <string>
#include <math.h>

#define BASE64 "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"

using namespace std;

struct base64 {
	static string Cifrar(string t);
	static string Descifrar(string t);

private:
	static string int2bin(int n, int base);
	static int bin2int(string b);
};
inline string base64::int2bin(int n, int bits = 8) {
	string r = string(bits, '0');
	while (n) {
		r.at(--bits) = ((n & 1) + 48);
		n >>= 1;
	}
	return r;
}
inline int base64::bin2int(string b) {
	int r = 0;
	for (int i = 0; i < b.length(); i++) r += b.at(b.length() - 1 - i) == '1' ? pow(2, i) : 0;
	return r;
}

/**********************************************************/
inline string base64::Cifrar(string t) {
	if (t == "") return "";

	string b = "", r = "", extra = "";
	for (auto c : t) b += int2bin(c);

	if (t.length() % 3 == 1) {// 3k + 1
		b += "0000";
		extra = "==";
	}
	if (t.length() % 3 == 2) {// 3k - 1
		b += "00";
		extra = "=";
	}

	for (int i = 0; i < b.length(); i += 6) r += BASE64[bin2int(b.substr(i, 6))];
	return r + extra;
}
inline string base64::Descifrar(string t) {
	if (t == "") return "";

	int numero_ceros = 0;
	while (t.at(t.length() - 1) == '=') {
		numero_ceros += 2;
		t = t.substr(0, t.length() - 1);
	}

	string b = "", r = "";
	for (auto c : t) b += int2bin(string(BASE64).find(c), 6);

	b += string('0', numero_ceros);
	for (int i = 0; i < b.length(); i += 8) r += bin2int(b.substr(i, 8));
	return r;
}