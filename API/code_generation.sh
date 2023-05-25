BASEDIR=$(dirname "$0")

# orca.* codegen

SHARED_PROJ_NAME=ClientLib
CLIENT_PROJ_NAME=ClientLib

GENERATION_DIR="$BASEDIR/$SHARED_PROJ_NAME"/MagicOnion/Generated

SHARED_PROJ_PATH=$SHARED_PROJ_NAME/$SHARED_PROJ_NAME.csproj

dotnet tool restore

rm -rf $GENERATION_DIR
dotnet mpc -i $SHARED_PROJ_PATH -o $GENERATION_DIR/Generated.MessagePack.cs -r MPResolver -n $SHARED_PROJ_NAME.MP
dotnet moc -i $SHARED_PROJ_PATH -o $GENERATION_DIR/Generated.MagicOnion.cs -u -n $CLIENT_PROJ_NAME.MagicOnion -m $SHARED_PROJ_NAME.MP.Formatters -c ENABLE_IL2CPP