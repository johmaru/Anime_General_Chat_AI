import spacy

nlp = spacy.load('ja_ginza')

for p in nlp.pipeline:

    print(p)