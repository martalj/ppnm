all: Out.txt Out_erf.txt erf.png

Out.txt: main.exe
	mono $< > $@

Out_erf.txt: erf.exe
	mono $< > $@

erf.png: Out_erf.txt
	cat log.gpi | pyxplot

main.exe: main.cs matlib.dll
	mcs -target:exe -reference:matlib.dll -out:$@ $<

erf.exe: erf.cs matlib.dll
	mcs -target:exe -reference:matlib.dll -out:$@ $<

matlib.dll: ../../../matlib/integrate/integrate.cs
	mcs -target:library -out:./$@ $^
