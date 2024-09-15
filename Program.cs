using System.ComponentModel;
using System.Runtime.CompilerServices;
string resposta;



int c = 0;
int h = 1;
int calculo = 2;

void loop(){
    Console.Clear();
Console.WriteLine("Digite quantos anos de vida tem o cachorro:");
resposta = Console.ReadLine()!;

if(int.TryParse(resposta, out c)){
    
    c = Convert.ToInt32(resposta);

}

if(int.TryParse(resposta, out h)){
    h = Convert.ToInt32(resposta);

Console.WriteLine("A idade do SequencePosition cachorro é:");
calculo = (h) * 4;
Console.WriteLine(calculo);
}



 Console.WriteLine("Você quer recomeçar o programa? [S/N]");
    string reposta = Console.ReadLine()!;
    if(reposta.ToUpper() == "S")
    {
    Console.ResetColor();
        loop();
    }
    else{

    }
}
loop();