module Tests.Types

open System
type Person = { Id: int; Name: string }
type LowerCaseId = { id: int; age:int }
type SimpleUnion = One | Two
type RecordWithSimpleUnion = { Id: int; Union: SimpleUnion }
type RecordWithList = { Id: int; List: int list }
type Maybe<'a> = Just of 'a | Nothing
type RecordWithGenericUnion<'t> = { Id: int; GenericUnion: Maybe<'t> }
type RecordWithDateTime = { id: int; created: DateTime }
type RecordWithMap = { id : int; map: Map<string, string> }
type RecordWithArray = { id: int; arr: int[] }
type RecordWithDecimal = { id: int; number: decimal }
type RecordWithLong = { id: int; long: int64 }
type RecordWithGuid = { id: int; guid: Guid }
type RecordWithBytes = { id: int; data:byte[] }
type RecordWithObjectId = { id: LiteDB.ObjectId }
type RecordWithOption = { id:int; generic: Option<int>  }
type Shape = 
    | Circle of float
    | Rect of float * float
    | Composite of Shape list

type RecordWithShape = { Id: int; Shape: Shape }

type ComplexUnion<'t> = 
    | Any of 't
    | Int of int
    | String of string 
    | Generic of Maybe<'t>
[<CLIMutable>]
type Company=
  {Id :int
   Name :string}   
[<CLIMutable>]    
type EOrder=
  { Id :int
    OrderNumRange :string }   
[<CLIMutable>]    
type Order=
  { Id :int
    Company :Company}
type PaperWeight=
|G300 =300
|G157=157
|G128=128
type CoatedPaper={PaperWeight:PaperWeight}
type Paper=
|CoatedPaper of CoatedPaper
[<CLIMutable>]
type OrderDetail=
 { Id:int
   Paper :Paper }