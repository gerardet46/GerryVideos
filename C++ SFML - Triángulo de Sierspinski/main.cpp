#include <SFML/Graphics.hpp>
#include <math.h>

#define SZ 800

float map(float val, float a, float b, float a1, float b1) {
    return a + (val - a) * (b1 - a1) / (b - a);
}

void draw_triang(sf::Vector2f p1, sf::Vector2f p2, sf::Vector2f p3, sf::Color col, sf::RenderWindow* win) {
    sf::VertexArray triangle(sf::Triangles, 3);

    triangle[0].position = p1;
    triangle[1].position = p2;
    triangle[2].position = p3;

    triangle[0].color = col;
    triangle[1].color = col;
    triangle[2].color = col;
  
    win->draw(triangle);
}

void sierspinski(int it, sf::Vector2f p1, sf::Vector2f p2, sf::Vector2f p3, sf::RenderWindow* win) {
    if (it == 0) return;

    float lado = p3.x - p2.x;

    sf::Vector2f
	q1(p1.x - lado / 4, (p1.y + p2.y) / 2),
	q2(p1.x + lado / 4, (p1.y + p2.y) / 2),
	q3(p1.x, p2.y);

    draw_triang(q1, q2, q3, sf::Color::Black, win);

    // arriba
    sierspinski(it - 1, p1, q1, q2, win);

// izquierda
    sierspinski(it - 1, q1, p2, q3, win);
    
    // arriba
    sierspinski(it - 1, q2, q3, p3, win);

}

void preparar(int it, float lado, sf::RenderWindow* win) {
    float h = lado * std::sqrt(3) / 2;
    float m = (SZ - h) / 2;

    sf::Vector2f
	p1(SZ / 2, m),
	p2(SZ / 2 - lado / 2, m + h),
	p3(SZ / 2 + lado / 2, m + h);

    draw_triang(p1, p2, p3, sf::Color::White, win);

    sierspinski(it, p1, p2, p3, win);
}

int main(int argc, char* const argv[]) {
    sf::RenderWindow* win = new sf::RenderWindow(sf::VideoMode(SZ, SZ), "Sierspinski", sf::Style::Close | sf::Style::Titlebar);
    win->setPosition(sf::Vector2i(sf::VideoMode::getDesktopMode().width * 0.5 - win->getSize().x * 0.5, sf::VideoMode::getDesktopMode().height * 0.5 - win->getSize().y * 0.5));
    win->setFramerateLimit(10);

    while (win->isOpen()) {
	sf::Event e;
	while (win->pollEvent(e)) {
	    if (e.type == sf::Event::Closed) win->close();
	}
	
	win->clear(sf::Color::Black);

	int mx = sf::Mouse::getPosition(*win).x;
	int it = map(mx, 0, SZ, 0, 10);

	if (mx < 0 || mx > SZ) it = 4;
	
	preparar(it, 0.9 * SZ, win);
	
	win->display();
    }
    return 0;
}
