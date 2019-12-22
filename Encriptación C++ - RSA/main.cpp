#include "rsa.h"

int main(int argc, const char** argv) {
    while (1) {
        cout << "1 -> generar claves, 2 -> encriptar, 3 -> desencriptar, 4 -> salir: ";

        char opt;
        cin >> opt;

        if (opt == '1') {
            // generar claves
            RSA::generar();
        } else if (opt == '2') {
            // encriptar
            string msg;
            InfInt e, n;

            cout << "Mensaje: ";
            cin.ignore();
            getline(cin, msg);

            cout << "e: ";
            cin >> e;

            cout << "n: ";
            cin >> n;

            auto r = RSA::encriptar(msg, e, n);
            for (auto n : r) {
                cout << n << "-";
            }
        } else if (opt == '3') {
            // desencriptar
            string msg;
            InfInt d, n;

            cout << "Mensaje: ";
            cin.ignore();
            getline(cin, msg);

            cout << "d: ";
            cin >> d;

            cout << "n: ";
            cin >> n;

            auto r = RSA::desencriptar(msg, d, n);
            cout << r;
        } else if (opt == '4') {
            break; // salimos
        }
        cout << "\n";
    }
    return 0;
}