Out.txt: main.exe
	mono $< > $@

main.exe: main.cs matlib.dll
	mcs -target:exe -reference:matlib.dll -out:$@ $<

matlib.dll: ../../../matlib/integrate/integrate.cs
	mcs -target:library -out:./$@ $^
