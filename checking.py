def is_palindrome(word) -> bool:
    if word is None or not isinstance(word,str):
        return False
    

    processed_word: str = word.replace(" ","").lower()

    return processed_word == processed_word[::-1]



input_word: str = input("\nEnter a word: ")

if is_palindrome(input_word):
    print(f"{input_word} is a palindrome")

else:
    print(f"{input_word} is not a palindrome")