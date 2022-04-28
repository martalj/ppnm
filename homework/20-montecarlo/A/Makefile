all: Out.txt mc.png mc2.png

Out.txt: main.exe
	mono $< > $@

mc.png: Out.txt
	cat fig.gpi | pyxplot

mc2.png: Out.txt
	cat fig2.gpi | pyxplot

main.exe: main.cs matlib.dll

LIBDIR = ../../../matlib

matlib.dll: \
	$(LIBDIR)/matrix/matrix.cs \
	$(LIBDIR)/matrix/vector.cs \
	montecarlo.cs
	mcs -target:library -out:$@ $^

%.exe: %.cs
	mcs -t:exe $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

%.dll: %.cs
	mcs -t:library $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

clean:
	$(RM) *.exe *.txt *.dll
