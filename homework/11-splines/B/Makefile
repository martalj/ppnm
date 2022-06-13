all: Out.txt spline_x2.png spline_Rand.png

Out.txt: main.exe
	mono $< > $@

spline_x2.png: Out.txt
	cat figx2.gpi | pyxplot

spline_Rand.png: Out.txt
	cat figRand.gpi | pyxplot

main.exe: main.cs quadspline.dll
	mcs -target:exe -reference:quadspline.dll -out:$@ $<

quadspline.dll: quadspline.cs
	mcs -target:library -out:$@ $<

clean:
	$(RM) *.png *.txt *.exe
