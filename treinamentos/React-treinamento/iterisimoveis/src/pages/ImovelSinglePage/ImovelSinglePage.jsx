import React, { useEffect, useState } from "react";
import { getImovelPorId } from "../../services/imovelApiService";
import ImovelCard from "../../components/ImovelCard";
import { useParams } from "react-router-dom";
function ImovelSinglePage() {
  const { id } = useParams();
  const [imovel, setImovel] = useState(null);
  useEffect(() => {
    getImovelPorId(id).then((data) => {
      setImovel(data);
    });
  }, [id]);
  if (imovel === null) {
    return <div>Carregando...</div>;
  } else {
    return (
      <div>
        <ImovelCard imovel={imovel} />
      </div>
    );
  }
}
export default ImovelSinglePage;