using System;

class notes {
    static void Main(){
        
        const int count=8;
        int note, iteration, mp_aproved, mp_losed, mp_med_aproved, mp_med_losed;
        iteration=mp_med_losed=mp_med_aproved=mp_losed=mp_aproved=0;
        
        
        while(iteration<count){
            Console.Write("Intordueix una nota: ");
            note=Convert.ToInt32(Console.ReadLine());
            while(note<0 || note>10){
                Console.WriteLine("La nota escrita no es natural o no esta en el interval [0,10], torna a introduirla: ");
                note=Convert.ToInt32(Console.ReadLine());
            }
            
            if(note>=5){
                mp_aproved++;
                mp_med_aproved+=note;
            }
            else {
                mp_losed++;
                mp_med_losed+=note;
            }
            iteration++;
        }
        
        Console.WriteLine("La quantitat de MP aprovats es " + mp_aproved + " i la nota mitjana aprovada es " + (mp_med_aproved/mp_aproved));
        Console.WriteLine("La quantitat de MP suspesos es " + mp_losed + " i la nota mitjana suspesa es " + (mp_med_losed/mp_losed));
    }
}
