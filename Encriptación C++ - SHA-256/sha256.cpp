#include "sha256.h"

int main() {
	string msg;
	while (1) {
		cout << "Escribe el mensaje:\n";
		cin >> ws;
		getline(cin, msg);

		string nuevo = SHA256::cifrar(msg);
		cout << "\nHash resultante: " << nuevo;

		// _getch();
		// system("cls");
		cout << "\n";
	}
	return 0;
}
