all: spline_random.png spline_x2.png Out.txt

Out.txt: main.exe
	mono $< > $@

spline_random.png: Out.txt
	cat fig.gpi | pyxplot

spline_x2.png: Out.txt
	cat fig2.gpi | pyxplot

main.exe: main.cs lint.dll
	mcs -target:exe -reference:lint.dll -out:$@ $<

lint.dll: lint.cs
	mcs -target:library -out:$@ $<

clean:
	$(RM) *.png *.txt *.exe
