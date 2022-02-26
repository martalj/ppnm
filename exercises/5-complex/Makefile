Out.txt: main.exe
	mono main.exe > Out.txt

main.exe: main.cs cmath.dll
	mcs -target:exe -reference:cmath.dll -out:main.exe main.cs

cmath.dll: cmath.cs complex.cs
	mcs -target:library -out:./cmath.dll $^ # note "./" in front of cmath.dll
