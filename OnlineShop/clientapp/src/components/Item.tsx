type ItemModel = {
    name:string
}

export const Item = (prop:ItemModel) =>{
    return (
        <div>
            <h2>{prop.name}</h2>
        <p>{prop.name}</p>
        </div>
    )
}