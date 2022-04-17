all: Out.txt pend.png

Out.txt: main.exe
	mono $< > $@

main.exe: main.cs matlib.dll

LIBDIR = ../../../matlib

pend.png: Out.txt
	cat fig_pend.gpi | pyxplot

matlib.dll: \
	$(LIBDIR)/matrix/matrix.cs \
	$(LIBDIR)/matrix/vector.cs \
	../../6-genlist/A/genlist.cs \
	ode.cs
	mcs -target:library -out:$@ $^

%.exe: %.cs
	mcs -t:exe $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

%.dll: %.cs
	mcs -t:library $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

clean:
	$(RM) *.exe *.txt *.dll *.png
