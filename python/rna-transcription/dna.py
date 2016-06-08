import sys

def to_rna(strand):
    trans = {'G':'C', 'C':'G', 'T':'A', 'A':'U' }
    out = ""
    
    for nuc in strand:
        if (nuc.isalpha()):
            nuc = nuc.upper()
            if (nuc in trans):
                out += trans[nuc]                
    
    return out
            
def main():
    print to_rna("GAT")

if __name__ == '__main__':
    sys.exit(int(main() or 0))