Out.txt: main.exe input.txt
	mono $< < input.txt > $@

input.txt: Makefile
	echo 1 2 3 4 5 > $@ 

main.exe: main.cs
	mcs -target:exe -out:$@ $<

clean:
	$(RM) [Oo]ut* *.exe [Ll]og*
