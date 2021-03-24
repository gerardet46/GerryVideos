CC	:= g++
LIBS	:= -lsfml-graphics -lsfml-window -lsfml-system
ENTRY	:= main
EXT	:= cpp
TARGETS	:= compile run

compile: all

run:
	$(CC) -o $(ENTRY) $(ENTRY).$(EXT) $(LIBS)
	./$(ENTRY)

all:
	$(CC) -o $(ENTRY) $(ENTRY).$(EXT) $(LIBS)
