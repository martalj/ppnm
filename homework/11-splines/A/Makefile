all: spline.png Out.txt

Out.txt: main.exe
	mono $< > $@

spline.png: Out.txt
	cat fig.gpi | pyxplot

main.exe: main.cs lint.dll
	mcs -target:exe -reference:lint.dll -out:$@ $<

lint.dll: lint.cs
	mcs -target:library -out:$@ $<

clean:
	$(RM) *.png *.txt *.exe
