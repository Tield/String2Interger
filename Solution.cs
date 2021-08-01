public class Solution {
    public int MyAtoi(string str) {
        str = str.Trim();
      if(str == "" || (!char.IsDigit(str[0]) && str[0] != '-' && str[0] != '+'))
        return 0;
      
      var isNegative = str[0] == '-';
      int result = 0;
      var i = isNegative || str[0] == '+' ? 1 : 0;
      
      for(; i < str.Length; i++)
      {
        if(!char.IsDigit(str[i]))
          break;
       
        try
        {
          checked
          {
            result *= 10;
            result += str[i] - '0';
          }
        }
        catch
        {
          return isNegative ? int.MinValue : int.MaxValue;
        }
      }
      
      return isNegative ? result * -1 : result;
    }
}
