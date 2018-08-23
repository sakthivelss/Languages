namespace DataStructure

module MyTree =
   
   type Tree<'LeafNode,'INodeData> =
    | LeafNode of 'LeafNode
    | InternalNode of 'INodeData*Tree<'LeafNode,'INodeData> seq


    