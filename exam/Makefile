all: Out.txt spline.png spline2.png spline3.png spline4.png

Out.txt: main.exe
	mono $< > $@

main.exe: main.cs matlib.dll

LIBDIR = ../../../matlib

spline.png: Out.txt
	cat fig.gpi | pyxplot

spline2.png: Out.txt
	cat fig2.gpi | pyxplot

spline3.png: Out.txt
	cat fig3.gpi | pyxplot

spline4.png: Out.txt
	cat fig4.gpi | pyxplot

matlib.dll: \
	quadspline.cs \
	spline.cs \
	cubicspline.cs \
	11qspline.cs \
	11cspline.cs
	mcs -target:library -out:$@ $^

%.exe: %.cs
	mcs -t:exe $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

%.dll: %.cs
	mcs -t:library $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

clean:
	$(RM) *.exe Out.* *.dll *.png
