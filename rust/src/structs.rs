use std::{fmt};
use std::ops::{Add, Sub, AddAssign, SubAssign};
use std::intrinsics::type_id;
use std::any::Any;

#[derive(Debug)]
enum Type {
    Vegetable,
    Fruit,
}

impl fmt::Display for Type {
    fn fmt(&self, f: &mut fmt::Formatter) -> fmt::Result {
        fmt::Debug::fmt(self, f)
    }
}

struct Thing {
    name: &'static str,
    thing_type: Type,
    weight: f32,
}

impl fmt::Display for Thing {
    fn fmt(&self, f: &mut fmt::Formatter) -> fmt::Result {
        write!(f, "{} {} weighs {}", self.thing_type.to_string(), self.name, self.weight)
    }
}

#[derive(Debug, Clone, Copy)]
struct Vec2(f32, f32);

impl fmt::Display for Vec2 {
    fn fmt(&self, f: &mut fmt::Formatter) -> fmt::Result {
        write!(f, "({:.2}, {:.2})", self.0, self.1)
    }
}

impl Add for Vec2 {
    type Output = Vec2;

    fn add(self, rhs: Self) -> Self::Output {
       Vec2 { 0: self.0 + rhs.0, 1: self.1 + rhs.1 }
    }
}

impl AddAssign for Vec2 {
    fn add_assign(&mut self, rhs: Self) {
        self.0 += rhs.0;
        self.1 += rhs.1;
    }
}

impl Sub for Vec2 {
    type Output = Vec2;

    fn sub(self, rhs: Self) -> Self::Output {
        Vec2 {0: self.0 - rhs.0, 1: self.1 - rhs.1}
    }
}

impl SubAssign for Vec2 {
    fn sub_assign(&mut self, rhs: Self) {
        self.0 -= rhs.0;
        self.1 -= rhs.1;
    }
}

#[derive(Debug)]
struct Arr<T, const SIZE: usize> {
    items: [T; SIZE]
}

pub(crate) fn run() {
    let apple = Thing { name: "Apple", thing_type: Type::Fruit, weight: 1.5_f32 };
    let onion = Thing { name: "Onion", thing_type: Type::Vegetable, weight: 0.75_f32 };
    println!("{}\n{}\n", apple, onion);
    let p1 = Vec2(0.0, 0.0);
    let p2 = Vec2(0.5, 0.5);
    let p_add = p1 + p2;
    let p_sub = p1 - p2;
    let mut p3 = Vec2(2.0, 2.0);
    p3 += p2;
    let mut p4 = Vec2(2.0, 2.0);
    p4 -= p3;
    println!("{}, {}", p1, p2);
    println!("{}, {}", p_add, p_sub);
    println!("{}, {}\n", p3, p4);

    let mut arr: Arr<u32, 4> = Arr {items: [1,2,3,4]};
    arr.items[3] = 6;
    println!("{:?}", arr.items)
}