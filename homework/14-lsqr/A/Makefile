all: Out.txt leastsq.png

Out.txt: main.exe input.data
	mono main.exe < input.data >> $@

main.exe: main.cs genlist.dll matlib.dll

LIBDIR = ../../../matlib

genlist.dll: genlist.cs

leastsq.png: Out.txt
	cat fig.gpi | pyxplot 

matlib.dll: \
	$(LIBDIR)/matrix/matrix.cs \
	$(LIBDIR)/matrix/vector.cs \
	gs.cs \
	leastsq.cs
	mcs -target:library -out:$@ $^

%.exe: %.cs
	mcs -t:exe $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

%.dll: %.cs
	mcs -t:library $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

clean:
	$(RM) *.exe *.txt *.dll
