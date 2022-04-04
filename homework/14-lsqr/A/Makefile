Out.txt: main.exe input.data
	mono main.exe < input.data >> $@

main.exe: main.cs genlist.dll

LIBDIR = ../../../matlib

genlist.dll: genlist.cs

matlib.dll: \
	$(LIBDIR)/matrix/matrix.cs \
	$(LIBDIR)/matrix/vector.cs \
	gs.cs
	mcs -target:library -out:$@ $^

%.exe: %.cs
	mcs -t:exe $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

%.dll: %.cs
	mcs -t:library $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

clean:
	$(RM) *.exe *.txt *.dll
