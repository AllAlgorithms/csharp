// HOW TO USE:
//
// Encode:  _msg -> a message that you want to encode
//          key  -> can be a word, a sentecen, you decide
//
// Decode:  _msg -> a message already encoded before
//          key  -> the same key used to encode _msg
// NOTES:
// 
// the algorithm will fill the table with chars from _key
// and ignore all duplicates chars
//
// 'I' and 'J' will be assumed as only one letter
//      So, if the decode msg == jojnthehacktoberfest
//      it means: join the hacktoberfest
// 
// if the last char cant form a pair, a 'Q' will be add to de end (nobody alone here, okay?)
//      decoded msg == abcq
//      it means:      abc
//
// ************** ONLY USE LETTERS AND BLANK SPACES, OTHERWISE, IT WILL CRASH **************
// ************** YOU HAVE BEEN WARNED *****************************************************
//
// have fun c:

static string playfair_lowcase(string _msg, string _key)
{
    const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    char[,] table = new char[5,5];
    int count = 0;

    //Remove all spaces and replace all 'i' with 'j'
    //Playfair also accepts remove a rare char(e.g. X or Q) instead
    string msg = _msg.Replace('i', 'j').Replace(" ", "");
    string key = (_key + alphabet).Replace('i', 'j').Replace(" ", "");

    //Check for char alones
    //Playfair only work with pairs
    if((msg.Length % 2) != 0)
        msg += 'q';

    //Remove duplicates from the key
    key = RemoveDuplicates(key);

    char[] msg_array = msg.ToCharArray();
    char[] key_array = key.ToCharArray();

    //Fill the table with key
    for(int x = 0; x < 5; x++)
        for(int y = 0; y < 5; y++)
        {
            table[x,y] = key_array[count];
            count++;
        }

    char A, B;
    int[] a = { 0, 0 };
    int[] b = { 0, 0 };
    bool aCheck = false; 
    bool bCheck = false;
    bool writed = false;

    string out_msg = "";

    //Encode All Sentence
    for(int x = 0; x < msg_array.Length; x ++)
    {
        A = msg_array[x];
        B = msg_array[(x + 1)];

        aCheck = false;
        bCheck = false;
        writed = false;

        //Get the pairs
        for(int y = 0; y < 5; y++)
            for(int z = 0; z < 5; z++)
            {
                //Get pos of A
                if(A == table[y,z])
                {
                    a[0] = y;
                    a[1] = z;

                    aCheck = true;
                }

                //Get pos of B
                if(B == table[y,z])
                {
                    b[0] = y;
                    b[1] = z;

                    bCheck = true;
                }

                //Get the AB pair encode/decode when the app have A and B
                if(aCheck && bCheck)
                    //Check write the same encode/decode pair only one time
                    if(!writed)
                    {
                        char aCh = table[a[0], b[1]];
                        char bCh = table[b[0], a[1]];

                        out_msg += aCh;
                        out_msg += bCh;

                        writed = true; 
                    }
            }

        x++;
    }
    
    return out_msg;
}

static string RemoveDuplicates(string str)
{
    return new string(str.ToCharArray().Distinct().ToArray());
}