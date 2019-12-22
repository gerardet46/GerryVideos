#include <iostream>
#include <stdlib.h>
#include <vector>
#include <string>
#include <tuple>
#include "InfInt.h"

using namespace std;

InfInt mcd(InfInt a, InfInt b) {
    if (b != 0) return mcd(b, a % b);
    return a;
}

// ax + by = mcd(a, b)
tuple<InfInt, InfInt, InfInt> euclides(InfInt a, InfInt b) {
    if (a == 0) return make_tuple(b, 0, 1);

    InfInt mcd, x, y;
    tie(mcd, x, y) = euclides(b % a, a);

    return make_tuple(mcd, y - (b / a) * x, x); // (mcd, x, y)
}

struct RSA {
    static void generar();
    static vector<InfInt> encriptar(string, InfInt, InfInt);
    static string desencriptar(string, InfInt, InfInt);
};

inline void RSA::generar() {
    InfInt p, q, n, phi, e, d;

    cout << "Escribe p: ";
    cin >> p;

    cout << "Escribe q: ";
    cin >> q;

    n = p * q;
    phi = (p - 1) * (q - 1);

    do {
        cout << "Escribe e (menor y coprimo con" << phi << "): ";
        cin >> e;
    } while (!(e < phi && mcd(e, phi) == 1));

    d = get<1>(euclides(e, phi));
    while (d < 0) d += phi;

    cout << "Modulo: " << n << endl;
    cout << "Clave publica: " << e << endl;
    cout << "Clave privada: " << d << endl;
}

InfInt modpow(InfInt base, InfInt exp, InfInt mod) {
    InfInt r = 1;

    while (--exp >= 0) {
        r *= base;
        r %= mod;
    }
    return r;
}

inline vector<InfInt> RSA::encriptar(string msg, InfInt e, InfInt n) {
    vector<InfInt> resultado;
    
    for (auto c: msg) {
        // c^e mod n
        resultado.push_back(modpow((int)c, e, n));
    }
    return resultado;
}

inline string RSA::desencriptar(string msg, InfInt d, InfInt n) {
    vector<InfInt> mensaje;

    string temp("");
    for (auto c : msg) {
        if (c == '-') {
            mensaje.push_back(temp);
            temp = "";
        } else temp += c;
    }
    if (temp.length() > 0) mensaje.push_back(temp);
    
    string resultado("");
    for (auto c : mensaje) {
        // c^d mod n
        auto numero = modpow(c, d, n);
        resultado += (char)(numero.toInt());
    }
    return resultado;
}