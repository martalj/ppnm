all: exp.png

Out.txt: main.exe
	mono $< > $@

main.exe: main.cs
	mcs -target:exe -out:$@ $<

exp.png: Out.txt
	cat log.gpi | pyxplot

clean:
	$(RM) *.png [Oo]ut* *.exe
