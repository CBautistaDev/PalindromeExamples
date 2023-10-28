static bool IsPalindrome(string word){
    

    //remove case sesitivty and spaces and set unform casing
    string processWrod = word.Replace(" ", "").ToLower();

    //compare characters from start and end towards the center

    int left=0;
    int right = processWrod.Length -1;


    while(left < right){

        if(!String.Equals(word[left],word[right])){
            return false;
        }

        left++;
        right--;
    }

    return true;
}


string input = Console.ReadLine();

System.Console.WriteLine(IsPalindrome(input));