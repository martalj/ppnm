all: Out.txt spline_x2.png spline_Rand.png

Out.txt: main.exe
	mono $< > $@

spline_x2.png: Out.txt
	cat figx2.gpi | pyxplot

spline_Rand.png: Out.txt
	cat figRand.gpi | pyxplot

main.exe: main.cs cspline.dll
	mcs -target:exe -reference:cspline.dll -out:$@ $<

cspline.dll: cspline.cs
	mcs -target:library -out:$@ $<

clean:
	$(RM) *.png *.txt *.exe
