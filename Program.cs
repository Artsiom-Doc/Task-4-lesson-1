// See https://aka.ms/new-console-template for more information
int N = 5;
while(N > 0)
{
   if(N % 2 == 0)
   {
    Console.WriteLine(N);
   }
   else
   {
    Console.WriteLine(N - 1);
    N = N - 1;
   }
N = N - 2;
}