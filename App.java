public class App {
    public static void main(String[] args) throws Exception {
        String Lista = "Atletico-MG, Cruzeiro, America-Mg, Villa Nova, Tombense";
        int numeroJogos = 1;
        String[] times = Lista.split(", ");

        for (int i = 0; i < times.length; i++) {
            for (int j = 0; j < times.length; j++) {
                if (i != j) {
                    System.out.println("[" + numeroJogos++ + "]" + times[i] + " X " + times[j]);
                }
            }
        }
        System.out.println();
        System.out.println(" Tabela 2: turno unico ");
        int totalTurnoUnico = 0;
        for (int i = 0; i < times.length; i++) {
            for (int j = i + 1; j < times.length; j++) {
                totalTurnoUnico++;
                System.out.println("[" + totalTurnoUnico + "] " + times[i] + " X " + times[j]);
            }
        }
        System.out.println();
        System.out.println("Total de confrontos no turno unico: " + totalTurnoUnico);
    }
}
