Out.txt: main.exe
	mono $< > $@

main.exe: main.cs table.dll
	mcs -target:exe -reference:table.dll -out:$@ $<

table.dll: table.cs
	mcs -target:library -out:table.dll table.cs
