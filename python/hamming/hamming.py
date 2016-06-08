def distance(strand1, strand2):
    if (len(strand1) != len(strand2)): return None
    
    ham = 0
    for i in range(0, len(strand1)):    
        if strand2[i] != strand1[i]:
            ham += 1
    
    return ham
