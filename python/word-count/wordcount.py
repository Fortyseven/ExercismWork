import re

def word_count(text):
    word_list = {}
    
    try:
        text = text.decode('utf-8')
    except:
        pass
        
    text = " ".join(re.split("[\W_]+", text.lower(), flags=re.UNICODE))
        
    for word in text.split(' '):
        if len(word):
            if word in word_list: 
                word_list[word] += 1
            else:
                word_list[word] = 1
                
    return word_list    
