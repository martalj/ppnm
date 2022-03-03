Out.txt: main.exe
	mono main.exe > Out.txt

main.exe: main.cs maxmin.dll
	mcs -target:exe -reference:maxmin.dll -out:main.exe main.cs

maxmin.dll: maxmin.cs
	mcs -target:library -out:maxmin.dll maxmin.cs
