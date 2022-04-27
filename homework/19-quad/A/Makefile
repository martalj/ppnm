all: Out.txt erf.png

Out.txt: main.exe
	mono $< > $@

erf.png: Out.txt tabpoints.data
	cat fig.gpi | pyxplot

main.exe: main.cs quad.dll

quad.dll: quad.cs

%.exe: %.cs
	mcs -t:exe $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

%.dll: %.cs
	mcs -t:library $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

clean:
	$(RM) *.exe *.txt *.dll
