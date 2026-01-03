def response(hey_bob):
    answers = ["Sure.", "Whoa, chill out!", "Calm down, I know what I'm doing!",
              "Fine. Be that way!", "Whatever."]
    question = hey_bob.strip()
    
    if question == '':
        return (answers[3])
        
    if question.endswith("?") and question.isupper():
        return(answers[2])
        
    if question.endswith("?"):
        return answers[0]
        
    if question.isupper():
        return answers[1]

    return answers[4]
