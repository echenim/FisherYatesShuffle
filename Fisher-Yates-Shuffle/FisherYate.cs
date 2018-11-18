using System;
using System.Collections.Generic;

namespace Fisher_Yates_Shuffle
{
    public class FisherYates
    {

        //generate random number
        private Random _rand = new Random();

        /**
        *shuffle method help to shuffle the incoming data set
         */
        public List<int> Shuffle(int [] data){
            
           var _list = new List<int>();

          for(var i=0; i<data.Length; ++i){

              var _rand_result = _rand.Next(i, data.Length); 
              var _temp = data[_rand_result];
              data[_rand_result] = data[i];
              data[i] = _temp;
               _list.Add( data[i]);

          }
         
         return _list;

        }
    }
}
