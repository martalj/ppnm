all: gamma.png lngamma.png

Out.txt: main.exe
	mono $< > $@

Out_ln.txt: main_ln.exe
	mono $< > $@

gamma.png: Out.txt tabpoints.txt
	cat log.gpi | pyxplot

lngamma.png: Out_ln.txt tabpoints.txt
	cat lnlog.gpi | pyxplot

main.exe: main.cs
	mcs -target:exe -out:$@ $<

main_ln.exe: main_ln.cs
	mcs -target:exe -out:$@ $<
clean:
	$(RM) *.png [Oo]ut* *.exe *.eps

