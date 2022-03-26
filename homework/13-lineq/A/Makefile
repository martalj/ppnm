Out.txt: main.exe
	mono $< > $@

main.exe: main.cs matlib.dll

LIBDIR = ../../../matlib

matlib.dll: \
	$(LIBDIR)/matrix/matrix.cs \
	$(LIBDIR)/matrix/vector.cs \
	gs.cs
	mcs -target:library -out:$@ $^

%.exe: %.cs
	mcs -t:exe $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

%.dll: %.cs
	mcs -t:library -out:./%.dll $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)
