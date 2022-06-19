all: Out.txt spline.png spline2.png

Out.txt: main.exe
	mono $< > $@

main.exe: main.cs matlib.dll

LIBDIR = ../../../matlib

spline.png: Out.txt
	cat fig.gpi | pyxplot

spline2.png: Out.txt
	cat fig2.gpi | pyxplot

matlib.dll: \
	quadspline.cs \
	spline.cs \
	cubicspline.cs
	mcs -target:library -out:$@ $^

%.exe: %.cs
	mcs -t:exe $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

%.dll: %.cs
	mcs -t:library $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

clean:
	$(RM) *.exe *.txt *.dll *.png
