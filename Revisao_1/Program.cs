System.Console.WriteLine("Digite o DDD: ");
int ddd = int.Parse(System.Console.ReadLine());

switch (ddd)
{
    case 41:
    case 42:
    case 43:
    case 44:
    case 45:
    case 46:
        System.Console.WriteLine("Paraná");
        break;
    case 51:
    case 53:
    case 54:
    case 55:
        System.Console.WriteLine("Rio Grande do Sul");
        break;
    case 61:
        System.Console.WriteLine("Brasília");
        break;
    case 62:
    case 64:
        System.Console.WriteLine("Goiás");
        break;
    case 65:
    case 66:
        System.Console.WriteLine("Mato Grosso");
        break;
    case 67:
        System.Console.WriteLine("Mato Grosso do Sul");
        break;
    default:
        System.Console.WriteLine("DDD não encontrado");
        break;
}