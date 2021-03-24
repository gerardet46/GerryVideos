#include <SFML/Graphics.hpp>
#include <iostream>
#include <math.h>

#define SZ 800

// devuelve las coordenadas del triángulo que divide en 4
void calc_central(float x, float y, float &px1, float &py1, float &px2, float &py2, float &px3, float &py3, float lado) {
  float h = lado * std::sqrt(3) / 2;

  px1 = x - lado / 4, py1 = y + h / 2;
  px2 = x + lado / 4, py2 = y + h / 2;
  px3 = x, py3 = y + h;
}

void calc_triang(float x, float y, float &x2, float &y2, float &x3, float &y3, float lado) {
  float h = lado * std::sqrt(3) / 2;

  x2 = x - lado / 2, y2 = y + h;
  x3 = x + lado / 2, y3 = y + h;
}


void draw_triang(float x1, float y1, float x2, float y2, float x3, float y3, sf::Color col, sf::RenderWindow* win) {
   sf::VertexArray triangle(sf::Triangles, 3);

  triangle[0].position = sf::Vector2f(x1, y1);
  triangle[1].position = sf::Vector2f(x2, y2);
  triangle[2].position = sf::Vector2f(x3, y3);

  triangle[0].color = col;
  triangle[1].color = col;
  triangle[2].color = col;
  
  win->draw(triangle);
}

void draw_sierspinki(float x, float y, float lado, sf::RenderWindow* win) {
  float px1 = 0, py1 = 0, px2 = 0, py2 = 0, px3 = 0, py3 = 0;

  calc_central(x, y, px1, py1, px2, py2, px3, py3, lado);

  draw_triang(px1, py1, px2, py2, px3, py3, sf::Color::Black, win);
}

void dibuixar(float &px1, float &py1, float &px2, float &py2, float &px3, float &py3, float lado, sf::RenderWindow* win) {
  // calculamos vértices iniciales
  float x = lado / 2;
  float y = lado * std::sqrt(3) / 6;
  
  float centroX = SZ / 2;
  float centroY = (SZ + y) / 2;

  px1 = centroX, py1 = centroY - 2 * y;
  px2 = centroX - x, py2 = centroY + y;
  px3 = centroX + x, py3 = centroY + y;

  draw_triang(px1, py1, px2, py2, px3, py3, sf::Color::White, win);
}

void iteracio(float lado, float x1, float y1, float fin_y, sf::RenderWindow* win) {
  float x2 = 0, y2 = 0, x3 = 0, y3 = 0;

  // triangle original
  calc_triang(x1, y1, x2, y2, x3, y3, lado);

  if (y2 > fin_y) return;
  // dibuixam es seu "sierspinki"
  draw_sierspinki(x1, y1, lado, win);

  // dos triangles d'abaix
  iteracio(lado, x2, y2, fin_y, win);
  iteracio(lado, x3, y3, fin_y, win);
}


int main(int argc, char* const argv[]) {
  sf::RenderWindow* win = new sf::RenderWindow(sf::VideoMode(SZ, SZ), "Sierspinski", sf::Style::Close | sf::Style::Titlebar);

  bool init = true;
  int it = 0;
  float L = 0.9 * SZ;
  float px1 = 0, py1 = 0, px2 = 0, py2 = 0, px3 = 0, py3 = 0;

  while (win->isOpen()) {
    sf::Event e;
    while (win->pollEvent(e)) {
      if (e.type == sf::Event::Closed) win->close();
      if (e.type == sf::Event::KeyPressed && e.key.code == sf::Keyboard::Space) {
	++it;
	
	iteracio(L, px1, py1, py2, win);

	L /= 2;
	win->display();
      }
    }

    // dibuixam
    if (init) {
      win->clear(sf::Color(0,0,0));

      dibuixar(px1, py1, px2, py2, px3, py3, L, win);
      
      win->display();

      init = false;
    }
  }
  return 0;
}
