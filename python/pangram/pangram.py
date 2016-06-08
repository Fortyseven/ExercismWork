import sys

def is_pangram(text):
    chars = []
    for ch in text:
        c = ch.lower()
        if (c.isalpha() and (not c in chars)):
            chars.append(c)
    return (len(chars)==26)
        
def main():
    print is_pangram("the quick brown fox jumps over the lazy dog")

if __name__ == '__main__':
    sys.exit(int(main() or 0))
        