module GradeSchool

type School = Map<int, string list>

let empty: School =
    Map.empty

let add (student: string) (grade: int) (school: School): School =
    match school.TryFind grade with
    | Some existingGrade -> school.Add(grade, student :: existingGrade |> List.sort)
    | None -> school.Add(grade, [student])

let roster (school: School): string list =
    school |> Seq.collect (fun x -> x.Value) |> List.ofSeq

let grade (number: int) (school: School): string list =
    match school.TryFind number with
    | Some _ -> school.Item number
    | None -> []