mod structs;

fn variables() {
    let x: i32 = 32;
    let y: i128 = 128;
    let z: f64 = 64.12345678901234567890;
    let a: f32 = 32.12345678901234567890;
    println!("{}, {}, {}, {}", x, y, z, a);
}

fn mutable_immutable() {
    let x: i32 = 1234;
    let mut y: i32 = 1234;
    y = 5;
    // x = 4; <- error
    println!("{}, {}", x, y);
}

fn data_types() {
    let _bool = true;
    let _i32 = 0;
    let _i64 = 0i64;
    let _u16 = 0_u16;
    let _f64 = 1.23;
    let _f32 = 1.23_f32;
    let _tuple = (1, "Hello", false);
    let _str = "Hello, world!";
    println!(
        "{}, {}, {}, {}, {}, {}\n({},{},{})\n{}",
        _bool, _i32, _i64, _u16, _f64, _f32, _tuple.0, _tuple.1, _tuple.2, _str
    );
}

fn type_conversion_and_constants() {
    let a = 16_u8;
    let b = 48_u32;
    let c = a as u32 + b;
    println!("{}", c);

    let d = true;
    println!("{}", d as u8);

    const WHATEVER: f32 = std::f64::consts::PI as f32;
    println!("{}", WHATEVER);
}

fn arrays() {
    let num_array: [i32; 4] = [1, 2, 3, 4];
    println!("{:?}", num_array);
    println!("{}", num_array[0]);
    println!("{}", num_array.len());
}

fn multiple_ret_values() {
    fn swap(a: i32, b: i32) -> (i32, i32) {
        return (b, a);
    }

    let a = 32_i32;
    let b = 64_i32;
    let (c, d) = swap(a, b);
    println!("{} {} ; {} {}", a, b, c, d);
}

fn loops() {
    let mut i = 0;
    loop {
        i += 1;
        if i == 10 {
            break;
        }
    }
    println!("[#loop]: {:?}", i);

    let v = loop {
        i += 1;
        if i == 20 {
            break std::format!("End of loop, reached i = {}", i);
        }
    };
    println!("From loop: {msg}", msg = v);

    let mut j = 0;
    while j != 10 {
        j += 1;
    }
    println!("[#while]: {:?}", j);

    print!("[#for]: ");
    for k in 0..10 {
        print!("{} ", k)
    }
    print!("\n")
}

fn pattern_matching(arg: i32) {
    match arg {
        0 => {
            println!("Found zero");
        }
        1 | 2 => {
            println!("Found 1 or 2");
        }
        3..=9 => {
            println!("Found 3 to 9 inclusive");
        }
        var2 @ 10..=100 => {
            println!("Found {} between 10 and 100", var2);
        }
        var3 @ _ => {
            println!("Found something else: {}", var3);
        }
    }
}

fn return_from_block_expr() -> i32 {
    let x = 32;
    let v = if x < 32 { -1 } else { 1 };
    println!("From if: {}", v);

    let food = "Hamburger";
    let result = match food {
        "hotdog" => "is hotdog",
        _ => "is not hotdog"
    };
    println!("From match: {}", result);

    let v2 = {
        let a = 1;
        let b = 2;
        a + b // return value if used without semicolon
    };
    println!("From block: {}", v2);

    // return value if used without semicolon
    v2 + 4
}

fn main() {
    println!("\n[variables]");
    variables();

    println!("\n[mutable_immutable]");
    mutable_immutable();

    println!("\n[data_types]");
    data_types();

    println!("\n[type_conversion_and_constants]");
    type_conversion_and_constants();

    println!("\n[arrays]");
    arrays();

    println!("\n[multiple_ret_values]");
    multiple_ret_values();

    println!("\n[loops]");
    loops();

    println!("\n[pattern_matching]");
    pattern_matching(0);
    pattern_matching(32);
    pattern_matching(6);
    pattern_matching(-123);

    println!("\n[return_from_block_expr]");
    return_from_block_expr();
    println!();

    structs::run();
}