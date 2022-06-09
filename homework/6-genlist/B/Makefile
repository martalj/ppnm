OUT = Out.txt

all:$(OUT)

$(OUT): main.exe
	mono $< > $@

main.exe:main.cs genlist.dll
	mcs -t:exe -out:$@ $(addprefix -r:,$(filter %.dll,$^)) $(filter %.cs,$^)

genlist.dll:genlist.cs
	mcs -target:library -out:$@ $<

clean:
	$(RM) *.dll *.exe *.data *.txt
