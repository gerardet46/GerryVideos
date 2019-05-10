#pragma once

#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <string>
#include <algorithm>

using namespace std;

struct Cesar {
	static string Cifrar(string t, int clave);
	static string Descifrar(string t, int clave);
};

inline string Cesar::Cifrar(string t, int clave) {
	transform(t.begin(), t.end(), t.begin(), toupper);

	string r = "";
	for (auto c : t) {
		if (isalpha(c)) {
			c += clave;

			if (c > 'Z') c -= 26;
			if (c < 'A') c += 26;
		}
		r += c;
	}
	return r;
}

inline string Cesar::Descifrar(string t, int clave) { return Cifrar(t, -clave); }
/*********************************************/

static const int CLAVES[10] = { 4,-7,1,-19,21,-5,8,17,-23,11 };

struct Sustitucion {
	static string Cifrar(string t);
	static string Descifrar(string t);

private:
	static string __enc(string t, bool invertir);
};

inline string Sustitucion::Cifrar(string t) { return __enc(t, false); }
inline string Sustitucion::Descifrar(string t) { return __enc(t, true); }

inline string Sustitucion::__enc(string t, bool invertir) {
	transform(t.begin(), t.end(), t.begin(), toupper);

	string r = "";
	int i = 0;
	for (auto c : t) {
		if (isalpha(c)) {
			if (!invertir) c += CLAVES[i];
			else c -= CLAVES[i];

			if (c > 'Z') c -= 26;
			if (c < 'A') c += 26;

			if (++i > 9) i = 0;
		}
		r += c;
	}
	return r;
}
