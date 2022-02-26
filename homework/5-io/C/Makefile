Out.txt: main.exe
	mono $< 1 2 3 4 5 > $@

main.exe: main.cs
	mcs -target:exe -out:$@ $<

.PHONEY:clean
clean:
	$(RM) [Oo]ut* *.exe [Ll]og*

