#include "base64.h"

int main() {
	string msg;
	int clave;

	while (1) {
		cout << "Selecciona:\n1 => Encriptar\n2 => Desencriptar";

		char opt;
		do {
            cin >> opt;
        } while (opt != '1' && opt != '2');

		cout << "Escribe el mensaje:\n";
		cin >> ws;
		getline(cin, msg);

		if (opt == '1') {
			// ENCRIPTAR
			auto nuevo = base64::Cifrar(msg);
			cout << "\nMensaje encriptado: " << nuevo;
		}
		else {
			// DESENCRIPTAR
			auto nuevo = base64::Descifrar(msg);
			cout << "\nMensaje descifrado: " << nuevo;
		}
	}
	return 0;
}
