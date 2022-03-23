all: Out.txt ode.png

Out.txt: main.exe
	mono $< 1> $@ 2>log

main.exe: main.cs matlib.dll
	mcs -target:exe -reference:matlib.dll -out:$@ $<

LIBDIR = ../../matlib
matlib.dll: \
	$(LIBDIR)/odeint/ode.cs \
	$(LIBDIR)/matrix/vector.cs
	mcs -target:library -out:./$@ $^

ode.png: Out.txt
	cat fig.gpi | pyxplot

clean:
	$(RM) *.dll *.png *.txt log*
