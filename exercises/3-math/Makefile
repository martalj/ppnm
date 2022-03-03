Out.txt: main.exe
	mono main.exe > Out.txt

main.exe: main.cs math.dll
	mcs -target:exe -reference:math.dll -out:main.exe main.cs

math.dll: math.cs
	mcs -target:library -out:math.dll math.cs

clean:
	$(RM) *.exe *.dll [Oo]ut.txt
