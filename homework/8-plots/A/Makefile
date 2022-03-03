Out.txt: main.exe
	mono $< > $@

erf.png: Out.txt tabpoints.txt log.gpi
	cat log.gpi | tee log.gpi | pyxplot

main.exe: main.cs
	mcs -target:exe -out:$@ $<
clean:
	$(RM) *.png log* [Oo]ut* *.exe tab*

