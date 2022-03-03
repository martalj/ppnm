all: gamma.png

Out.txt: main.exe
	mono $< > $@

gamma.png: Out.txt tabpoints.txt
	cat log.gpi | pyxplot

main.exe: main.cs
	mcs -target:exe -out:$@ $<
clean:
	$(RM) *.png [Oo]ut* *.exe *.eps

