fn main() {
    let lista = "Atletico-MG, Cruzeiro, America-Mg, Villa Nova, Tombense";
    let times: Vec<&str> = lista.split(", ").collect();

    println!(" Tabela 1: ida e volta ");
    let mut numero_jogos = 1;
    for i in 0..times.len() {
        for j in 0..times.len() {
            if i != j {
                println!("[{}] {} X {}", numero_jogos, times[i], times[j]);
                numero_jogos += 1;
            }
        }
    }

    println!();
    println!(" Tabela 2: turno unico ");
    let mut total_Turno_unico = 0;
    for i in 0..times.len() {
        for j in (i + 1)..times.len() {
            total_Turno_unico += 1;
            println!("[{}] {} X {}", total_Turno_unico, times[i], times[j]);
        }
    }

    println!();
    println!("Total de confrontos no turno unico: {}", total_turno_unico);
}
