all: spline.png Out.txt

Out.txt: main.exe
	mono $< > $@

spline.png: Out.txt
	cat fig.gpi | pyxplot

main.exe: main.cs
	mcs -target:exe -out:$@ $<
clean:
	$(RM) *.png *.txt *.exe
