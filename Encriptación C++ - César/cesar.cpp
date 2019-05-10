#include "cesar.h"

int cesar() {
	string msg;
	int clave;

	while (1) {
		cout << "Selecciona:\n1 => Encriptar\n2 => Desencriptar";

		char opt;
		do opt = _getch(); while (opt != '1' && opt != '2');
		system("cls");

		cout << "Escribe la clave: ";		
		cin >> clave;

		cout << "Escribe el mensaje:\n";	
		cin >> ws;
		getline(cin, msg);

		if (opt == '1') {
			string nuevo = Sustitucion::Cifrar(msg);
			cout << "\nMensaje encriptado: " << nuevo;
		} else {
			string nuevo = Sustitucion::Descifrar(msg);
			cout << "\nMensaje descifrado: " << nuevo;
		}
		_getch();
		system("cls");
	}
	return 0;
}